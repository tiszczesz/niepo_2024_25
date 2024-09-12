import './PictureComp.css';
import picBicycle from '../assets/rower2.jpg';
const PictureComp = () => {
    return (
        <div className='picture'>
            <h5 style={{textAlign: 'center'}}>Rower</h5>
            <img src={picBicycle} alt="rower" />
        </div>
    )
}

export default PictureComp;