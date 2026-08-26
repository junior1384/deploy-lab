const http = require("http");

const PORT = process.env.PORT || 3000;
const ENVIRONMENT = process.env.ENVIRONMENT || "LOCAL";
const VERSION = process.env.VERSION || "1.0.0";

const server = http.createServer((req, res) => {
  res.writeHead(200, { "Content-Type": "text/html; charset=utf-8" });

  res.end(`
        <!DOCTYPE html>
        <html>
        <head>
            <meta charset="UTF-8">
            <title>Deploy Lab</title>
        </head>
        <body>
            <h1>Deploy Lab</h1>
            <p><strong>Ambiente:</strong> ${ENVIRONMENT}</p>
            <p><strong>Versão:</strong> ${VERSION}</p>
        </body>
        </html>
    `);
});

server.listen(PORT, () => {
  console.log(`Aplicação rodando na porta ${PORT}`);
  console.log(`Ambiente: ${ENVIRONMENT}`);
  console.log(`Versão: ${VERSION}`);
});
