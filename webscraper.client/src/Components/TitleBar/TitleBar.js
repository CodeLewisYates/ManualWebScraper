import styled from "styled-components";

const TitleBar = (props) => {

    const Bar = styled.div`
        height: 50px;
        width: 100%;
        display: flex;
        box-shadow: 2px 0 10px rgba(0,0,0,0.5);
        backgroundColor: #fff;
        align-items: center;
        padding: 0 15px;
        grid-row: 1;
        grid-column-start: 1;
        grid-column-end: 3;
    `
    const Title = styled.div`
        font-size: 16px;
        font-weight: 600;
        vertical-align: center;
    `

    return (
        <Bar>
            <Title>InfoTrack Web Scraper</Title>
        </Bar>
    )
}

export default TitleBar;