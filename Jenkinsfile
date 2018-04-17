pipeline {
  agent any
  stages {
    stage('coucou') {
      parallel {
        stage('coucou') {
          steps {
            echo 'coucou'
          }
        }
        stage('coucou2') {
          steps {
            echo 'coucou2'
          }
        }
        stage('coucou3') {
          steps {
            echo 'coucou3'
          }
        }
      }
    }
    stage('determine directory') {
      steps {
        pwd()
      }
    }
    stage('') {
      steps {
        fileExists 'Prefabs.meta'
      }
    }
  }
}