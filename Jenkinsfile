pipeline {
    agent any

    stages {
        stage('SonarQube') {
                def sqScannerMsBuildHome = tool 'Sonar MS'
                echo "${sqScannerMsBuildHome}"
        }
    }
}
