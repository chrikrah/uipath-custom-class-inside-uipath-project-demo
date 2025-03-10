- Dokumentation von Coded Workflows/Source Files:
https://docs.uipath.com/studio/standalone/2024.10/user-guide/coded-automations-introduction
- Nachdem die Klasse in einem *.cs file definiert wurde kann sie in Invoke Code Aktivitäten referenziert werden aber auch bspw. als Typ einer neuer Variable verwendet werden:
![image](https://github.com/user-attachments/assets/ffefe42c-a782-4584-9a00-4e77fcddab94)
- In Coded Source Files kann grundsätzlich beliebige Klassenlogik definiert werden, die dann in Invoke Code Aktivitäten referenziert werden kann.
- Wenn die API von Coded Workflows (dokumentiert unter dem Link oben) verwendet wird, dann lässt sich die Logik auch über Invoke Workflow Aktivitäten aufrufen. Hier mit ein paar Einschränkungen (bspw. können keine subclasses/nested classes verwendet werden)

Mögliche Use Cases:
- Definition der Struktur für ein HTTP POST JSON Payload, bspw. indem man das Data Transfer Object aus der API-Definition verwendet. Mehr Details hier: https://github.com/chrikrah/uipath-building-json-demo
- Performance-Optimierung (bspw. kann man eigene Logik definieren, wenn die Standard Studio-Aktivitäten nicht den Anforderungen genügen)
- ...

Des Weiteren haben viele UiPath Standard Aktivitäten eine API, die sich direkt im Code aufrufen lässt (hier sind bspw. die APIs der System Activities dokumentiert: https://docs.uipath.com/activities/other/latest/workflow/system-apis). Die standard low-code flows können so auf custom "pro-code" Logik zugreifen wie oben beschrieben und "pro-code" kann umgekehrt auch auf low-code Bulding Blocks zugreifen. Ein gutes Tutorial dazu findet sich hier: https://docs.uipath.com/studio/standalone/2023.10/user-guide/creating-hybrid-automations
