import ReactPaginate from "react-paginate";
import { useEffect, useState} from "react";
import "./Pagination.css";
import cx from "classnames";

const Pagination = (props) => {

    const {count, rowsPerPage, onPageChange} = props;

    const [currentPage, setCurrentPage] = useState(0);

    const handlePageChange = (page) => {
        setCurrentPage(page.selected);
        onPageChange(page.selected);
    }

    return (
        <ReactPaginate
            breakLabel="..."
            nextLabel="Next"
            previousLabel="Prev"
            pageRangeDisplayed={5}
            pageCount={Math.ceil(count / rowsPerPage)}
            onPageChange={(newPage) => handlePageChange(newPage)}
            containerClassName="paginationContainer"
            previousLinkClassName={cx([
                {["navBase"]: true},
                {["previous"]: currentPage >= 1},
                {["previousDisabled"]: currentPage === 0}
            ])}
            nextLinkClassName={cx([
                {["navBase"]: true},
                {["next"]: currentPage != Math.ceil(count / rowsPerPage)-1},
                {["nextDisabled"]: currentPage === Math.ceil(count / rowsPerPage)-1}
            ])}
            pageLinkClassName="page"
            activeLinkClassName="activePage"
            breakLinkClassName="breakLink"
            marginPagesDisplayed={1}
            
        />
    )
}

export default Pagination;