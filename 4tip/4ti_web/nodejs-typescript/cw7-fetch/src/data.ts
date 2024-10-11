export async function GetPosts(url:string='https://jsonplaceholder.typicode.com/posts') {
    const response = await fetch(url);
    const data = await response.json();
    return data;    
}