pipeline {
    agent any
    environment {
        SONAR = tool 'SonarMS'
    }
    stages {
        stage('SonarQube') {
            steps {
                script {
                   // requires SonarQube Scanner 2.8+
                   scannerHome = tool 'SonarMS'
                }
                withSonarQubeEnv('Sonar MS') {
                    bat ""${scannerHome}\\SonarQube.Scanner.MSBuild.exe" begin /k:MyAppKey /n:MyAppName /v:1.0 /d:sonar.host.url=%SONAR_HOST_URL% /d:sonar.login=%SONAR_AUTH_TOKEN%"
                    bat 'dotnet build'
                    bat ""${scannerHome}\\SonarQube.Scanner.MSBuild.exe" end /d:sonar.login=%SONAR_AUTH_TOKEN%"
                }
            }
        }
    }
}
