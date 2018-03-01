echo "*************Building node UI*************"
npm install
ng build  --target=production --environment=prod --aot=false --output-hashing=none
exit -Not($?)
