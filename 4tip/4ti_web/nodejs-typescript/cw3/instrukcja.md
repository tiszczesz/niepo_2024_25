## Praca z typescript

```console
mkdir katwork
npm init -y
npm i --save-dev typescript
npx tsc -init

```

### tsconfig.json

```json
{
  "module": "NodeNext",
  "rootDir": "./src",
  "outDir": "./dist"
}
```
### komilacja i uruchomienie

utworzyc katalogi src i dist

```console
 npx tsc
 node ./dist/jakisPlikWykonawczy
```