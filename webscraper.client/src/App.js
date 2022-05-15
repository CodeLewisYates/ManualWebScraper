import {
  Main,
  Content,
} from "./AppStyles";
import TitleBar from "./Components/TitleBar/TitleBar";
import Navigation from "./Components/Navigation/Navigation";
import Router from "./Router";
import { BrowserRouter } from "react-router-dom";

function App() {
  return (
    <BrowserRouter>
      <Main>

        <Content>
          <TitleBar />
          <Navigation />
          <Router />
        </Content>

      </Main>
    </BrowserRouter>
  );
}

export default App;