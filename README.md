# zezeTestDealer2

Repo sandbox **desechable**: consumidor de `DllCore`. La version vive a proposito en
**tres sintaxis** distintas y hay **tres decoys** que un reemplazo ingenuo corrompe.

| # | archivo | sintaxis | debe cambiar |
|---|---|---|---|
| 1 | `deps/dllcore.version` | valor desnudo | SI |
| 2 | `src/Dealer/Dealer.csproj` | segmento de carpeta en `HintPath` | SI |
| 3 | `src/Dealer/Dealer.csproj` | `<DllCoreVersion>` entrecomillado por XML | SI |
| D1 | `src/DealerExtra/DealerExtra.csproj` | `1.0.0.79` | **NO** |
| D2 | `src/DealerExtra/DealerExtra.csproj` | `1.0.0.795` | **NO** |
| D3 | `src/DealerExtra/neighbour.version` | `1.0.0.18-beta` | **NO** |
