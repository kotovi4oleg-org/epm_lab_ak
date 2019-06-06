pipeline {
    agent any
    environment {
        SONAR = tool 'SonarMS'
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
