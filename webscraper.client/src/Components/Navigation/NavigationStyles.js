import styled from "styled-components";

export const Container = styled.div`
    width: 200px;
    height: 100%;
    background-color: #2E2D2E;
    grid-row: 2;
    grid-column: 1;
`

export const Menu = styled.nav`
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    margin-top: 20px;
`

export const MenuItem = styled.div`
    color: #fff;
    font-size: 16px;
    font-weight: 400;
    cursor: pointer;
    text-align: center;
    width: 100%;
    padding: 20px;
`
export const ActiveMenuItem = styled(MenuItem)`
    background-color: rgba(6,105,159, 1);
    box-shadow: 0 0 10px rgba(0,0,0,0.5);
`
