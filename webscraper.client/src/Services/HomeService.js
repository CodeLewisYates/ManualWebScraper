import axios from "../Api/axios";


const HomeService = {
    sendSearchQuery: (keywords, searchFor, searchEngineId) => sendSearchQuery(keywords, searchFor, searchEngineId),
    getSearchEngines: () => getSearchEngines(),
}

const sendSearchQuery = async (keywords, searchFor, searchEngineId) => {
    const response = await axios.post(`search`, {
        keywords,
        searchFor,
        searchEngineId
    });

    return response;
}

const getSearchEngines = async () => {
    const response = await axios.get(`searchEngine`);
    return response;
}

export default HomeService;