import styled from "styled-components";

export const Content = styled.div`
    width: max-content;
    margin: 0 auto;
    margin-top: 20px;
    max-width: 800px;
    @media (max-width: 1150px) {
        width: 90%;
    }
`

export const LoaderContainer = styled.div`
    margin: 20px auto 0 auto;
    width: max-content;
`

export const Keywords = styled.div`
    display: flex;
    flex-direction: row;
    margin: 30px 0 10px 0;
    justify-content: center;
    align-items: center;
`

export const KeywordsText = styled.p`
    font-size: 17px;
    font-weight: 600;
    @media (max-width: 1000px) {
        font-size: 14px;
    }
`

export const KeywordsInput = styled.input`
    border-radius: 5px;
    border: 1px solid rgba(0,0,0,0.6);
    padding: 8px;
    width: 300px;
    margin-left: 10px;
    color: #0578AF;
    font-weight: 600;
    text-align:center;
    font-size: 16px;
    @media (max-width: 1000px) {
        width: 100%;
    }
`

export const SearchInputContainer = styled.div`
    position: relative;
`
export const SearchInput = styled.input`
    border-radius: 5px;
    border: 1px solid rgba(0,0,0,0.6);
    padding: 8px;
    width: 100%;

`
export const SearchInputIcon = styled.div`
    position: absolute;
    right: 10px;
    top: 54%;
    transform: translateY(-50%);
`

export const SearchButton = styled.button`
    padding: 12px 25px;
    color: #fff;
    background-color: #06699F;
    font-size: 20px;
    font-weight: 600;
    border: none;
    outline: none;
    border-radius: 7px;
    display: block;
    margin: 0 auto;
    margin-top: 20px;
    cursor: pointer;
    box-shadow: -2px 2px 10px rgba(0,0,0,0.5);
    transition: all 0.2s;
    &:hover {
        transform: scale(1.02);
        box-shadow: -2px 2px 15px 1px rgba(0,0,0,0.5);
    }
`

export const SearchResults = styled.div`
    text-align: center;
    margin-top: 20px;
`
export const SearchResultsText = styled.p`
    font-size: 18px;
    font-weight: 600;
`
export const SearchResultsValue = styled.p`
    color: #06699F;
    font-size: 24px;
    font-weight: 600;
`   