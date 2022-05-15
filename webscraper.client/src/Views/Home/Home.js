import HomeService from "../../Services/HomeService";
import Title from "../../Components/Title/Title";
import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import Loader from "../../Components/Loader/Loader";
import {AiOutlineSearch} from "react-icons/ai";
import {
    Content,
    Keywords,
    KeywordsInput,
    KeywordsText,
    SearchInputContainer,
    SearchInput,
    SearchInputIcon,
    SearchButton,
    SearchResults,
    SearchResultsText,
    SearchResultsValue,
    LoaderContainer
} from "./HomeStyles";

const Home = (props) => {

    const navigate = useNavigate();

    useEffect(() => {
        services();
    }, []);

    const services = async () => {
        /*
            Reason we are getting search engines here is to make it expandable to extra search engines.
            For now it is just google.
        */
        const data = await HomeService.getSearchEngines();
        if (data?.error) {
            navigate(`/error?${data.message}`);
            return;
        }
        setSearchEngines(data);
    }

    const [searchEngines, setSearchEngines] = useState(null);
    const [keywords, setKeywords] = useState("");
    const [searchFor, setSearchFor] = useState("www.infotrack.co.uk");
    const [load, setLoad] = useState(false);
    const [searchResults, setSearchResults] = useState(null);

    const submitSearch = async () => {
        setSearchResults(null);
        setLoad(true);
        const response = await HomeService.sendSearchQuery(keywords, searchFor, 1);
        setLoad(false);
        setSearchResults(response);
    }

    return (
        <>
            <Title />
            {!searchEngines && (
                <LoaderContainer>
                    <Loader />
                </LoaderContainer>
            )}
            {searchEngines && (
                <Content>
                    <Keywords>
                        <KeywordsText>URL to search for...</KeywordsText>
                        <KeywordsInput value={searchFor} onChange={(e) => setSearchFor(e.target.value)} />
                    </Keywords>
                    <SearchInputContainer>
                        <SearchInput placeholder="Keywords i.e. land registry search" onChange={(e) => setKeywords(e.target.value)} />
                        <SearchInputIcon><AiOutlineSearch size={24} /></SearchInputIcon>
                    </SearchInputContainer>
                    <SearchButton onClick={() => submitSearch()}>Search</SearchButton>

                    {load && (
                        <LoaderContainer>
                            <Loader />
                        </LoaderContainer>
                    )}

                </Content>
            )}
                    {searchResults && (
                        <SearchResults>
                            <SearchResultsText>
                                <SearchResultsValue>{searchFor}&nbsp;</SearchResultsValue>
                                {"appeared at position(s)"}
                            </SearchResultsText>
                            <SearchResultsValue>{searchResults.positions.replace(/\s/g, ", ")}</SearchResultsValue>

                            <SearchResultsText style={{marginTop: "10px", fontStyle: "italic"}}>The search has been added to the search history!</SearchResultsText>
                        </SearchResults>
                    )}

        </>
    )
}

export default Home;