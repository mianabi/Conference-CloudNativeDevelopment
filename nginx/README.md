
 cd nginx/
 sudo openssl req -x509 -nodes -days 365 -newkey rsa:2048 -keyout api-cert.key -out api-cert.crt -config api-cert.conf -passin pass:p@sswd1

api-cert.key
api-cert.crt

sudo openssl pkcs12 -export -out api-cert.pfx -inkey api-cert.key -in api-cert.crt
 api-cert.pfx
 Run api-cert.pfx and install it on Trusted Root Certification Authorities


sudo openssl req -x509 -nodes -days 365 -newkey rsa:2048 -keyout mvc-cert.key -out mvc-cert.crt -config mvc-cert.conf -passin pass:p@sswd1
mvc-cert.key
mvc-cert.crt

sudo openssl pkcs12 -export -out mvc-cert.pfx -inkey mvc-cert.key -in mvc-cert.crt

mvc-cert.pfx
Run mvc-cert.pfx and install it on Trusted Root Certification Authorities
   
