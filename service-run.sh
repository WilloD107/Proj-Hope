#!/bin/bash
serviceName="project-Hope"

# ====================
# 
# ====================
dotnet publish "src/Hope/Hope.csproj" --output "bin" --runtime linux-x64 --self-contained \
  "-p:Configuration=Release" \
  "-p:DebugType=None" \
  "-p:GenerateRuntimeConfigurationFiles=true" \
  "-p:PublishSingleFile=true"

# ====================
# 
# ====================
if [ $serviceName != "Hope" ]; then
  mv "bin/Hope" "bin/${serviceName}"
fi

# ====================
# 
# ====================
"bin/${serviceName}"
