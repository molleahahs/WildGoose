import { message } from "antd"
import axios, { AxiosError, AxiosResponse } from "axios"
import { getUser, signinRedirect, signinSilent } from "./auth"

export interface ApiResult {
  code: number
  success: boolean
  // eslint-disable-next-line @typescript-eslint/no-explicit-any
  data: undefined | object | PageData<any>
  msg: string
  errors: ApiError[]
}

export interface ApiError {
  name: string
  messages: string[]
}

export interface Error {}

axios.defaults.withCredentials = true
// 创建 axios 实例
const instance = axios.create({
  timeout: 300 * 1000, // 请求超时时间
})

// Request interceptor
instance.interceptors.request.use(async (requestConfig) => {
  requestConfig.headers["z-application-id"] = "wildgoose-web"
  const user = await getUser()
  if (user) {
    requestConfig.headers["z-user-id"] = user.profile.sub
    let displayName = `${user.profile.family_name}${user.profile.given_name}`
    if (!displayName && user.profile.name) {
      displayName = user.profile.name
    }
    if (!displayName && user.profile.nickname) {
      displayName = user.profile.nickname
    }
    requestConfig.headers["z-user-name"] = encodeURIComponent(displayName)
    if (user.access_token) {
      requestConfig.headers["Authorization"] = `Bearer ${user.access_token}`
    }
  }

  return requestConfig
})

// Response interceptor
instance.interceptors.response.use(
  // eslint-disable-next-line @typescript-eslint/no-explicit-any
  (response: AxiosResponse<ApiResult | any, any>) => {
    const result = response.data as ApiResult
    if (!result) {
      // 1. 若没有返回数据，则根据 statusCode 来判断
      if (response.status < 200 && response.status >= 300) {
        const msg = "服务请求错误: " + response.status
        message.error(msg)
        throw msg
      }
      return response
    }

    // 请求失败
    if (!result.success || result.code !== 0) {
      if (result.msg) {
        message.error(result.msg)
        throw result.msg
      } else {
        if (result.errors) {
          const msg = result.errors.map((e) => {
            return `${e.name}： ${e.messages} `
          })
          message.error(msg)
          throw msg
        } else {
          throw "未知的错误"
        }
      }
    }

    return response
  },
  (error: AxiosError) => {
    // localStorage.setItem(E_Storage.LOGOUT_PAGE, window && window.location && window.location.pathname)
    // localStorage.removeItem(E_Storage.USER)
    // localStorage.removeItem(E_Storage.EXPIRE_TIME)
    // localStorage.removeItem(E_Storage.USER_PASSWORD_STRENGTH)
    // window.location.href = `${config.pathPrefix}/`
    if (error.response?.status === 401) {
      const handle401 = async () => {
        const user = await getUser()
        if (user && user.refresh_token) {
          await signinSilent()
        } else {
          await signinRedirect()
        }
      }
      handle401()
    }

    const apiResult = error.response?.data as ApiResult
    if (!apiResult) {
      message.error("未知错误")
    } else {
      if (apiResult.errors || message.error.length > 0) {
        const msg = apiResult.errors.map((x) => {
          return "\n".concat(...x.messages)
        })
        message.error(msg)
      } else {
        if (apiResult.msg) {
          message.error(apiResult.msg)
        } else {
          message.error("未知错误")
        }
      }
    }
    return error
  }
)

export { instance as request }
