FROM node:8.6.0-alpine

WORKDIR /root/

COPY package.json .

RUN npm i
COPY handler.js .

CMD ["node", "handler.js"]