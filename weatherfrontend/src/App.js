import './app.css';
import {React , Component} from "react";

class BODY extends Component
{

  
  constructor(props){
    super(props);

    this.state = {
      coord: {lon: new Number, lat: new Number},
      weather: [{description: new String}],
      main: new Number,
      sys: new String,
      name: new String
    };
  }

  async componentDidMount() {
    const url = "https://localhost:7276/weather";
    const response = await fetch(url);
    const data = await response.json();
    this.setState({coord: data["coord"], weather: data["weather"], main: data["main"], sys: data["sys"], name: data["name"]})
  }

  render(){
    return (
      <div className='main'>
        {this.state.weather[0]["description"]}
        {this.state.main.temp}
      </div>
    );
  }

}

const App = () => {
  return (
    <div className="App">
      <BODY />
    </div>
  );
}

export default App;
