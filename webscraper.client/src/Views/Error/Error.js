import styled from "styled-components";
import { useLocation } from "react-router-dom";

const Error = (props) => {

    const location = useLocation();

    const ErrorComponent = styled.div`
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        margin-top: 60px;
    `

    const ErrorMessage = styled.p`
        font-size: 26px;
        font-weight: 600;
        color: grey;
    `

    const ErrorSubMessage = styled.p`
        font-size: 20px;
        font-weight: 400;
        color: grey;
        margin-top: 10px;
    `

    const ErrorDetails = styled.p`
        font-size: 18px;
        font-weight: 400;
        color: grey;
        margin-top: 20px;
    `

    return (
        <ErrorComponent>
            <ErrorMessage>Oh no! Something went wrong!</ErrorMessage>
            <ErrorSubMessage>Make sure API is running</ErrorSubMessage>
            <ErrorDetails>Error message:&nbsp;{location.search.replace("?","").replace(/%20/, " ")}</ErrorDetails>
        </ErrorComponent>
    )
}

export default Error;