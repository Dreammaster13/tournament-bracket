import { fetch } from "../utilities";
import { Entrant } from "./entrant.model";

export class EntrantService {
    
    private static _instance: EntrantService;

    public static get Instance() {
        this._instance = this._instance || new EntrantService();
        return this._instance;
    }

    public get() {
        return fetch({ url: "/api/entrant/get" });
    }

    public getById(id) {
        return fetch({ url: `/api/entrant/getbyid?id=${id}`, authRequired: true });
    }

    public add(entity) {
        return fetch({ url: `/api/entrant/add`, method: "POST", data: entity, authRequired: true  });
    }

    public remove(options: { id : number }) {
        return fetch({ url: `/api/entrant/remove?id=${options.id}`, method: "DELETE", authRequired: true  });
    }
    
}
