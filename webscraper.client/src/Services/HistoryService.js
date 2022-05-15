import axios from "../Api/axios";

const HistoryService = {
    getHistoryService: () => getHistoryService(),
}

const getHistoryService = async () => {
    const response = await axios.get(`searchHistory`);
    return response;
}

export default HistoryService;