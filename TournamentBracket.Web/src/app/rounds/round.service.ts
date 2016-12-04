import { fetch } from "../utilities";
import { Round } from "./round.model";

export class RoundService {
    
    private static _instance: RoundService;

    public static get Instance() {
        this._instance = this._instance || new RoundService();
        return this._instance;
    }

    public get() {
        return fetch({ url: "/api/round/get" });
    }

    public getById(id) {
        return fetch({ url: `/api/round/getbyid?id=${id}`, authRequired: true });
    }

    public add(entity) {
        return fetch({ url: `/api/round/add`, method: "POST", data: entity, authRequired: true  });
    }

    public remove(options: { id : number }) {
        return fetch({ url: `/api/round/remove?id=${options.id}`, method: "DELETE", authRequired: true  });
    }
    
}
