FROM mysql:5.7.22
EXPOSE 3306
COPY ./rest_api_udemy/db/migrations/ /home/database/
COPY ./rest_api_udemy/db/dataset/ /home/database/
COPY ./rest_api_udemy/ci/init_database.sh/ /docker-entrypoint-initdb.d/init_database.sh