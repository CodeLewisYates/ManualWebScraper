import {
    Container,
    Menu,
    MenuItem,
    ActiveMenuItem,
} from "./NavigationStyles";
import {routes} from "../../config";
import { useLocation, useNavigate } from "react-router-dom";
import { useEffect, useState } from "react";
import {GiHamburgerMenu} from "react-icons/gi";

const Navigation = (props) => {

    const location = useLocation();
    const navigator = useNavigate();

    const [currentPath, setCurrentPath] = useState("/");
    
    useEffect(() => {
        setCurrentPath(location.pathname);
    }, [location]);

    const navigate = (path) => {
        navigator(path);
    }

    return (
        <>
            <Container>
                <Menu>
                    {routes.map(route => (
                        <>
                            {route.path === currentPath ? (
                                <ActiveMenuItem>{route.route}</ActiveMenuItem>
                            ) : (
                                <MenuItem onClick={() => navigate(route.path)}>{route.route}</MenuItem>  
                            )}
                        </>
                    ))}
                </Menu>
            </Container>
        </>
    )
}

export default Navigation;