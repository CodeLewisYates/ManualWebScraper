import { Routes, Route, Navigate } from "react-router-dom";
import Home from "./Views/Home/Home";
import styled from "styled-components";
import Error from "./Views/Error/Error";
import History from "./Views/History/History";

const View = styled.div`
    width: 100%;
    height: 100%;
    grid-column: 2;
    grid-row: 2;
`

const Router = (props) => {

    return (
        <View>
            <Routes>
                <Route exact path="/home" element={<Home />} />
                <Route exact path="/history" element={<History />} />
                <Route exact path="/error" element={<Error />} />
                <Route path="/" element={<Navigate to="/home" />} />
            </Routes>
        </View>
    )
}

export default Router;