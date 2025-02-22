@echo off
tasklist | findstr /I "Student Management with DB.exe" >nul
if %errorlevel% == 0 (
    taskkill /IM "Student Management with DB.exe" /F
) else (
    echo Process not found, skipping.
)
exit 0
