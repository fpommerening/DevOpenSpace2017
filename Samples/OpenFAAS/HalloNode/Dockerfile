FROM node:8.6.0-alpine

ADD https://github.com/alexellis/faas/releases/download/0.6.5/fwatchdog /usr/bin
RUN chmod +x /usr/bin/fwatchdog

WORKDIR /root/

COPY package.json .

RUN npm i
COPY handler.js .

ENV fprocess="node handler.js"

HEALTHCHECK --interval=1s CMD [ -e /tmp/.lock ] || exit 1

CMD ["fwatchdog"]