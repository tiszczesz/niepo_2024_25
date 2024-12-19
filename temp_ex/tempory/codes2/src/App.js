import { checkProps } from "./components/check-props";
import { UserInfo } from "./components/user-info";

const UserInfoWrapper = checkProps(UserInfo);

function App() {
  return (
    <>
      <UserInfoWrapper propA="test1" blabla={{ a: 1, age: 23 }} />
    </>
  );
}

export default App;
