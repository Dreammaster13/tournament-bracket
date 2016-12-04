import { fetch } from "../utilities";
import { Bracket } from "./bracket.model";

export class BracketService {
    
    private static _instance: BracketService;

    public static get Instance() {
        this._instance = this._instance || new BracketService();
        return this._instance;
    }

    public get() {
        return fetch({ url: "/api/bracket/get" });
    }

    public getById(id) {
        return fetch({ url: `/api/bracket/getbyid?id=${id}`, authRequired: true });
    }

    public add(entity) {
        return fetch({ url: `/api/bracket/add`, method: "POST", data: entity, authRequired: true  });
    }

    public remove(options: { id : number }) {
        return fetch({ url: `/api/bracket/remove?id=${options.id}`, method: "DELETE", authRequired: true  });
    }
    
}
