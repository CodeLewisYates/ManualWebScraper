import styled from "styled-components";

export const Content = styled.div`
    width: 90%;
    padding: 0 10px;
    margin: 0 auto;
`

export const TableTitle = styled.h1`
    font-size: 26px;
    font-weight: 600;
    margin-top: 10px;
`

export const Table = styled.table`
    margin-top: 20px;
    border-spacing: 0;
    border: 1px solid black;
`

export const TableRow = styled.tr`
    border: 1px solid red;
`

export const TableHeaderRow = styled.tr`
    background-color: #06699F;
`

export const TableHeader = styled.th`
    padding: 5px;
    color: #fff;
`

export const TableData = styled.td`
    text-align: center;
    padding: 8px;
    border: 1px solid rgba(0,0,0,0.3);
    
`
export const PaginationContainer = styled.div`
    width: max-content;
    margin: 15px 0 0 auto;
`