# IdentityServer4

Replicating SSL problem when running IS4 and IS4.AccessTokenValidation in same API.  You should probably add the localhost.pfx cert to your local Trusted Root Certification Authorities.

The problem occurs when targeting 452.  So you need to set your profile in Visual Studio to run the 452 version of the build when you "run" the project within VStudio.  (You can do this in the "Run" drop-down at the top, there is a menu option to set which target framework you want to run the project as)

The password for the cert is:  DominickRocks!   (welllllllll....   he does, let's be honest)

Run solution, and then retrieve a token:
https://localhost:5443/connect/token  (you have to add client_id, client_secret, and grant_type to the body per standard OIDC protocol)

Once you have token, add it to your Authorization header for the next request (e.g. use Postman):
https://localhost:5443/identity

It will return error related to its attempt at retrieving OIDC discovery document.




