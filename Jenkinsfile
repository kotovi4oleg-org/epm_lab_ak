pipeline {
    agent any
    environment {
        SONAR = tool 'Sonar MS'
    }
    stages {
        stage('SonarQube') {
            steps {
                withSonarQubeEnv('My SonarQube Server') {
                  echo 'SonarQube' + SONAR
                }
            }
        }
    }
}
