# Org.OpenAPITools - Azure Functions v4 Server

The methods are restricted to portal user that have the permission for sending documents. Different API versions work differently - be sure 
you know what you're doing, before you set an API version. The portal may define a minimum API version that can't be overridden.

Before you can use the REST API for your portal, you need to accept the DSGVO AVV once. Also, the REST API is currently restricted to customers 
that bought a PDFMAILER (non-Pure) license from gotomaxx directly, or are coming from XRechnung.new or ZUGFeRD.new.

If you don't know how to get your personal Bearer token (which is required to call any API method), please contact our technical support.

In case your REST client doesn't support OAuth2 or Bearer token, there are other possibilities for authentication:

- Use basic http authentication with your user credentials
- Send a valid session ID as value in the parameter (GET or POST) `__sid` with every request

Please ask our technical staff for instructions how to create a valid session ID that can be used with this REST API.

__NOTE__: Boolean parameter values should be given as `1` (`true`) or `0` (`false`).

__NOTE__: The XRechnung API functionality requires a separate license and user permission.

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```
## Run in Docker

```
cd src/Org.OpenAPITools
docker build -t org.openapitools .
docker run -p 5000:8080 org.openapitools
```
