import React, {Component} from 'react';
import './App.css';
import { Header, Icon } from 'semantic-ui-react';
import Activity from './Activity';

class App extends Component {

  render() {
    return (
      <div>
        <Header as="h2">
          <Icon name='users'/>
          <Header.Content>
            Reactivities
          </Header.Content>
        </Header>
        <Activity/>
        
    </div>
    );
  }
}

export default App;
