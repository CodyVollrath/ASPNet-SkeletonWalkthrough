import axios from 'axios';
import React, {Component} from 'react';

class Activity extends Component {
    state = {
        activities: []
      }
    
    componentDidMount() {
        axios.get('http://localhost:5000/api/Activities').then(
          (response) => {
            console.log(response);
            this.setState({
              activities: response.data
            })
          }
        )
    }
    render(){
        return(
            <ul>
            {this.state.activities.map((activity: any) => (
                <li key = {activity.id}> 
                Title: {activity.title}, Description: {activity.description} City: {activity.city}, Category: {activity.category}, Date: {new Date(activity.date).toLocaleDateString()}
                </li>
            ))}
            </ul>
        );

    }
}
export default Activity;