import React, { Component } from 'react';

export class FetchData extends Component {
  displayName = FetchData.name

  constructor(props) {
    super(props);
    this.state = { recipies: [], loading: true };

    fetch('api/Recipies')
      .then(response => response.json() )
      .then(data => {
        this.setState({ recipies: data, loading: false });
      });
  }

  static renderRecipiesTable(recipies) {
    return (
      <table className='table'>
        <thead>
          <tr>
            <th>Title</th>
            <th>Description</th>
          </tr>
        </thead>
        <tbody>
          {recipies.map(r =>
            <tr key={r.id}>
              <td>{r.title}</td>
              <td>{r.description}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderRecipiesTable(this.state.recipies);

    return (
      <div>
        <h1>All Recipies</h1>
        {contents}
      </div>
    );
  }
}
