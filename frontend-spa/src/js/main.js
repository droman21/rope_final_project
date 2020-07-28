import Employee from './components/Employee';
import Priority from './components/Priority';
import Status from './components/Status';
import ReleaseTasks from './components/ReleaseTasks';
import ReleaseTask from './components/ReleaseTask';
import ReleaseTaskEdit from './components/ReleaseTaskEdit';
import ReleaseTaskPostSection from './components/ReleaseTaskPostSection';
import ReleaseTaskPostSection from './components/ReleaseTaskPostSection';


export default function pagebuild(){
    header()
    footer()
    home()
    showReleaseTask()
    showEmployees()
    showStatus()
    showPririty()    
}
function header() {
    const header = document.querySelector('.header');
    header.innerHTML = Header();

