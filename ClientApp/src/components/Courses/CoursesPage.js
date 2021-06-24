﻿import React, { Component } from 'react';
import Category from './Category';
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
<<<<<<< HEAD
import FrontEndCourse from './FrontEndCourse';
import BackEndCourse  from './BackEndCourse';
import VisualCourse from './VisualCourse';
import Maincourse from './Maincourse';
=======
import { FrontEndCourse } from './FrontEndCourse';
import { BackEndCourse }  from './BackEndCourse';
import { VisualCourse } from './VisualCourse';
>>>>>>> 5e4a7724efcabcaa9220a11bf0f178d37a73f021
import { SideBarLayout } from '../SideBarLayout';
import { Courses } from './Courses';


export class CoursesPage extends Component {
    render() {
        return (
            <>
                        <SideBarLayout>
                           
                                <Route exact path='/userpage/course' component={Courses} />
                                <Route path='/userpage/course/frontend' component={FrontEndCourse} />
                                <Route path='/userpage/course/backend' component={BackEndCourse} />
                                <Route path='/userpage/course/visual' component={VisualCourse} />
                                
                        </SideBarLayout>
              
              
                    

                <Route path='/userpage/course/maincourse' component={Maincourse} />
                            
                          
                      

           
                    
            </>)
    }
};
/*export default CoursesPage;*/
/*export class CoursesPage extends Component {
    static displayName = CoursesPage.name;

    constructor(props) {
        super(props);
        this.state = { courses: [], loading: true };
    }

    componentDidMount() {
        this.populateData();
    }

    static renderTable(courses) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Domain</th>
                        <th>Rating</th>
                        <th>Course Link</th>
                    </tr>
                </thead>
                <tbody>
                    {courses.map(course =>
                        <tr key={course}>
                            <td>{course.coursename}</td>
                            <td>{course.coursedomain}</td>
                            <td>{course.courserating}</td>
                            <td>{course.courseurl}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading..</em></p>
            : CoursesPage.renderTable(this.state.courses);

        return (
            <div>
                <h1 id="tabelLabel" >List of courses</h1>
                {contents}
            </div>
        );
    }

    async populateData() {
        *//*const response = await fetch('Course');*//*
        const response = await fetch('Course');
        *//*const response = await fetch('Course/getbydomain/Frontend');*//*

        const data = await response.json();
        console.log(data)
        this.setState({ courses: data, loading: false });
    }
}
*/