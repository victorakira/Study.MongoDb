docker pull mongo
docker run --name mongodb -p 27017:27017 -e MONGO_INITDB_ROOT_USERNAME=user -e MONGO_INITDB_ROOT_PASSWORD=senha1234 mongo

connection string
mongodb://user:senha1234@localhost:27017/admin
