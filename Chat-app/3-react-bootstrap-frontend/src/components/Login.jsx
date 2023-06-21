import React, { useRef } from "react";
import { v4 as uuidV4 } from "uuid";
import { Container, Form, Button } from "react-bootstrap";

const Login = ({ onIdSubmit }) => {
  const idRef = useRef();

  const handeSubmit = (e) => {
    e.preventDefault();

    onIdSubmit(idRef.current.value);
  };

  const createNewId = () => {
    onIdSubmit(uuidV4());
  };

  return (
    <Container className='align-items-center d-flex' style={{ height: "100vh" }}>
      <Form onSubmit={handeSubmit} className='w-100'>
        <Form.Group>
          <Form.Label>Enter Id</Form.Label>
          <Form.Control type='text' ref={idRef} required />
        </Form.Group>
        <Button type='submit' className='me-2'>
          Login
        </Button>
        <Button onClick={createNewId} variant='secondary'>
          Create new Id
        </Button>
      </Form>
    </Container>
  );
};

export default Login;
