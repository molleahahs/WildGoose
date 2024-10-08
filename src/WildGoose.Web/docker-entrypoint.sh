#!/bin/sh

version=$(date +%s)

if [ ! -e "/app/index_o.html" ]; then
    cp /app/index.html /app/index_o.html
fi
cp -f /app/index_o.html /app/index.html

path=${BASE_PATH}
if [[ -z "${BASE_PATH}" ]]; then
    path=${PATH_BASH}
fi
sed -i "s#/config.js#${path}config_${version}.js#g" /app/index.html
sed -i "s#/assets/index-#${path}assets/index-#g" /app/index.html

# 输入文件名
input_file="/app/config.js"
# 输出文件名
output_file="/app/config_${version}.js"

if [ -f "${input_file}" ]; then
    awk '{
       while (match($0, /\$\{[A-Za-z_][A-Za-z0-9_]*\}/)) {
           var=substr($0, RSTART+2, RLENGTH-3)
           gsub(/\$\{[A-Za-z_][A-Za-z0-9_]*\}/, ENVIRON[var])
       }
       print
   }' "$input_file" >"$output_file"
fi
