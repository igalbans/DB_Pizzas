# ContosoPizza

## How to run using Docker

### Build

```sh
docker build -t pizza-app .
```

### Run

```sh
docker run -p 80:80 pizza-app
```

### Swagger Test UI

Navigate to http://localhost/swagger/index.html to load Swagger Test UI.

### Consume via CURL

```sh
curl -X 'GET' 'http://localhost/pizza' | jq
```