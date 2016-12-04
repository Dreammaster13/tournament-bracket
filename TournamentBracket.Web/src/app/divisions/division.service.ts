import { fetch } from "../utilities";
import { Division } from "./division.model";

export class DivisionService {
    
    private static _instance: DivisionService;

    public static get Instance() {
        this._instance = this._instance || new DivisionService();
        return this._instance;
    }

    public get() {
        return fetch({ url: "/api/division/get" });
    }

    public getById(id) {
        return fetch({ url: `/api/division/getbyid?id=${id}`, authRequired: true });
    }

    public add(entity) {
        return fetch({ url: `/api/division/add`, method: "POST", data: entity, authRequired: true  });
    }

    public remove(options: { id : number }) {
        return fetch({ url: `/api/division/remove?id=${options.id}`, method: "DELETE", authRequired: true  });
    }
    
}
