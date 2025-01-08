in this Section:

1-Configured NGINX as a Reverse Proxy Server

2-Configured SSL Termination
 
  2-1- Generates SSL Certificates(Self=Signed) with openssl in Linux
 
  2-2- Imported Certificates to proxy Server
 
  2-3- Configures SSL cert trust between client and API

3-Configured internal Docker Compose Network For Services

4-Registered DNS names for Services and Proxy Server Requests

to Generate key and crt file Certificates(Self=Signed) with openssl in Linux:
```yml
 cd nginx/
 sudo openssl req -x509 -nodes -days 365 -newkey rsa:2048 -keyout api-cert.key -out api-cert.crt -config api-cert.conf -passin pass:p@sswd1
````
after run Generate this Files in nginx Folder:

1-api-cert.key

2-api-cert.crt

to Generate pfx file Certificates(Self=Signed) with openssl in Linux:
```yml
sudo openssl pkcs12 -export -out api-cert.pfx -inkey api-cert.key -in api-cert.crt
```
after run Generate this Files in nginx Folder:

api-cert.pfx

Run api-cert.pfx and install it on Trusted Root Certification Authorities

cd nginx/
sudo openssl req -x509 -nodes -days 365 -newkey rsa:2048 -keyout mvc-cert.key -out mvc-cert.crt -config mvc-cert.conf -passin pass:p@sswd1
mvc-cert.key
mvc-cert.crt

sudo openssl pkcs12 -export -out mvc-cert.pfx -inkey mvc-cert.key -in mvc-cert.crt

mvc-cert.pfx
Run mvc-cert.pfx and install it on Trusted Root Certification Authorities
   
