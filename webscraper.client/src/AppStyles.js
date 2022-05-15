import styled from "styled-components";

export const Main = styled.div`
    width: 100vw;
    height: 100vh;
    background: linear-gradient(128deg, rgba(9,73,121,1) 25%, rgba(0,189,255,1) 100%);
    display: flex;
    justify-content: center;
    align-items: center;
`

export const Content = styled.div`
    width: 75%;
    height: 700px;
    background-color: #fff;
    border-radius: 5px;
    display: grid;
    grid-template-rows: 50px 1fr;
    grid-template-columns: 200px 1fr;
    overflow: hidden;
    box-shadow:
        0 2.8px 2.2px rgba(0, 0, 0, 0.034),
        0 6.7px 5.3px rgba(0, 0, 0, 0.048),
        0 12.5px 10px rgba(0, 0, 0, 0.06),
        0 22.3px 17.9px rgba(0, 0, 0, 0.072),
        0 41.8px 33.4px rgba(0, 0, 0, 0.086),
        0 100px 80px rgba(0, 0, 0, 0.12);
    @media (max-width: 1000px) {
        width: 90%;
    }
`