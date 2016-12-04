import { fetch } from "../utilities";
import { Match } from "./match.model";

export class MatchService {
    
    private static _instance: MatchService;

    public static get Instance() {
        this._instance = this._instance || new MatchService();
        return this._instance;
    }

    public get() {
        return fetch({ url: "/api/match/get" });
    }

    public getById(id) {
        return fetch({ url: `/api/match/getbyid?id=${id}`, authRequired: true });
    }

    public add(entity) {
        return fetch({ url: `/api/match/add`, method: "POST", data: entity, authRequired: true  });
    }

    public remove(options: { id : number }) {
        return fetch({ url: `/api/match/remove?id=${options.id}`, method: "DELETE", authRequired: true  });
    }
    
}
