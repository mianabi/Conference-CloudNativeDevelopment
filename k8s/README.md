after install K8S to access cluster by dashbord folow this link:

https://kubernetes.io/docs/tasks/access-application-cluster/web-ui-dashboard/

```yml
kubectl apply -f ./k8s/namespace.yml
kubectl apply -f ./k8s/api-deployment.yaml
kubectl apply -f ./k8s/mssql-deployment.yaml
kubectl apply -f ./k8s/mssql-deployment.yaml
kubectl apply -f ./k8s/mvc-client-deployment.yaml
```
