FROM node:9.11.1-alpine as builder

WORKDIR /app

COPY package.json /app/

RUN npm install

COPY ./ /app/

ARG env=prod

RUN npm run build -- --prod --environment $env 

FROM nginx:1.13-alpine 

copy --from=builder /app/dist/ /usr/share/nginx/html 

copy ./nginx-custom.conf /etc/nginx/conf.d/defualt.conf 