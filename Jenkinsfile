pipeline {
    agent any

    stages {
        stage('SonarQube') {
            steps {
                def sqScannerMsBuildHome = tool 'Sonar MS'
                echo "${sqScannerMsBuildHome}"
            }
        }
    }
}
