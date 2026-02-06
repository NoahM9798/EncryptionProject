# EncryptionProject

Encryption API (CI/CD)
A .NET 9 API demonstrating a full CI/CD pipeline with automated testing and AWS deployment.

# Live Demo
Test the API on AWS -> http://encryptionapi-env.eba-rve3rwpv.eu-north-1.elasticbeanstalk.com/encrypt?text=hello

# CI/CD & Git Flow
This project uses Git Flow to manage code quality:

Features: Developed in dedicated branches (e.g., feature/xunit).

Development: Merged into dev for integration and automated testing.

Main: Final merges to main trigger the deployment to AWS.

# API Endpoints
Encrypt: /encrypt?text=hello (Shifts +3)

Decrypt: /decrypt?text=khoor (Shifts -3)
