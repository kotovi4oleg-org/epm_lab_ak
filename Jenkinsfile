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
                    echo '${scannerHome}'
                }
            }
        }
    }
}
