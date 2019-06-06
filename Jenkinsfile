pipeline {
    agent any

    stages {
        stage('SonarQube') {
            steps {
                def sqScannerMsBuildHome = tool 'Sonar MS'
                withSonarQubeEnv('My SonarQube Server') {
                  echo "${sqScannerMsBuildHome}"
                }
            }
        }
    }
}
