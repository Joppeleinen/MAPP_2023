REM Run this script to automatically install or reinstall all packages,
REM as it's performed by the Unity Download Assistant.
REM Needs to be run with superuser permissions.

"UnitySetup64.exe" -UI=reduced /D=C:\Program Files\Unity 2021.3.20f1
"UnitySetup-Android-Support-for-Editor-2021.3.20f1.exe" /S /D=C:\Program Files\Unity 2021.3.20f1
"UnitySetup-iOS-Support-for-Editor-2021.3.20f1.exe" /S /D=C:\Program Files\Unity 2021.3.20f1
