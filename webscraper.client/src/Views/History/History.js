import { useEffect, useState } from "react";
import Title from "../../Components/Title/Title";
import Loader from "../../Components/Loader/Loader";
import HistoryService from "../../Services/HistoryService";
import { useNavigate } from "react-router-dom";
import Pagination from "../../Components/Pagination/Pagination";
import {
    Content,
    TableTitle,
    Table,
    TableHeader,
    TableHeaderRow,
    TableRow,
    TableData,
    PaginationContainer
} from "./HistoryStyles";

const History = (props) => {

    const navigate = useNavigate();

    useEffect(() => {
        services();
    }, []);

    const services = async () => {
        const data = await HistoryService.getHistoryService();
        if (data?.error) {
            navigate(`/error?${data.message}`)
            return;
        }
        setSearchHistory(data);
    }

    const [searchHistory, setSearchHistory] = useState(null);
    const [rowsPerPage, setRowsPerPage] = useState(8);
    const [page, setPage] = useState(0);

    return (
        <>
        <Title />
        {searchHistory ? (
            <Content>
                <TableTitle>Search History</TableTitle>
                <Table>
                    <TableHeaderRow>
                        <TableHeader style={{width: "300px"}}>Search Engine</TableHeader>
                        <TableHeader style={{width: "300px"}}>Keywords</TableHeader>
                        <TableHeader style={{width: "300px"}}>URL Searched</TableHeader>
                        <TableHeader style={{width: "300px"}}>Date</TableHeader>
                        <TableHeader style={{width: "300px"}}>Rankings</TableHeader>
                    </TableHeaderRow>
                    {searchHistory.length === 0 ? (
                        <TableRow>
                            <TableData style={{textAlign: "center"}} colSpan={5}>No search history available yet!</TableData>
                        </TableRow>
                    ) : (
                        <>
                        {searchHistory.slice(page * rowsPerPage, (page*rowsPerPage) + rowsPerPage).map(search => (
                            <TableRow>
                                <TableData>{search.searchEngineUsed}</TableData>
                                <TableData>{search.keywords}</TableData>
                                <TableData>{search.searchedFor}</TableData>
                                <TableData>{new Date(search.date).toLocaleDateString()}</TableData>
                                <TableData>{search.positions}</TableData>
                            </TableRow>
                        ))}
                        </>
                    )}
                </Table>
                <PaginationContainer>
                    <Pagination
                        count={searchHistory.length}
                        rowsPerPage={rowsPerPage}
                        onPageChange={(newPage) => setPage(newPage)}
                    />
                </PaginationContainer>
            </Content>
        ) : (
            <div style={{margin: "20px auto 0 auto", width: "max-content"}}>
                <Loader />
            </div>
        )}
        </>
    )
}

export default History;