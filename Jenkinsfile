pipeline {
    agent any
    stages {
        stage('SonarQube') {
            steps {
                script {
                   scannerHome = tool 'SonarMSBuild'
                   scannerBuild = "${scannerHome}/SonarScanner.MSBuild.dll"
                   projectKey = env.GIT_URL.tokenize('/')[3].split("\\.")[0].replace("_", "")
                }
		    echo "WORKSPACE - ${WORKSPACE}"
		    echo "JENKINS_HOME - ${JENKINS_HOME}"
		    echo "GIT_COMMITTER_EMAIL - ${env.GIT_COMMITTER_EMAIL}"
		    echo "GIT_AUTHOR_EMAIL - ${env.GIT_AUTHOR_EMAIL}"
                withSonarQubeEnv('SonarServer') {
                    echo "%SONAR_HOST_URL%"
                    sh "dotnet ${scannerBuild} begin /k:${projectKey} /n:${projectKey} /v:1.0 /d:sonar.host.url=${SONAR_HOST_URL} /d:sonar.issuesReport.html.enable=true"
                    sh 'dotnet build'
                    sh "dotnet ${scannerBuild} end"
                    sh "java -jar /etc/sonar-cnes-report.jar -p ${projectKey} -s ${SONAR_HOST_URL}"
                }
            }
        }
    }
}
