import React from "react";
import Login from "./components/Login";
import Dashboard from "./components/Dashboard";
import useLocalStorage from "./hooks/useLocalStorage";

const App = () => {
  const [id, setId] = useLocalStorage("id");

  return id ? <Dashboard id={id} /> : <Login onIdSubmit={setId} />;
};

export default App;
