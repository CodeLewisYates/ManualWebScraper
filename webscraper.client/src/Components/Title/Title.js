import styled from "styled-components";

const TitleComponent = styled.div`
    font-size: 56px;
    font-weight: 400;
    text-align: center;
    margin-top: 20px;
`
const SubTitle = styled.h5`
    font-size: 22px;
    color: #0578AF;
    text-align: center;
`

const Title = (props) => {


    return (
        <>
            <TitleComponent>InfoTrack</TitleComponent>
            <SubTitle>Web Scraper</SubTitle>
        </>
    )
}

export default Title;